// See https://aka.ms/new-console-template for more information

using System.Configuration;
using ConsoleApp3.domain;
using ConsoleApp3.repository;
using log4net.Config;

class MainClass
{
    public static void Main(string[] args)
    {
        //configurare jurnalizare folosind log4net
        XmlConfigurator.Configure(new System.IO.FileInfo("app.config"));
        Console.WriteLine("Configuration Settings for tasksDB {0}", GetConnectionStringByName("concurs"));
        IDictionary<String, string> props = new SortedList<String, String>();
        props.Add("ConnectionString", GetConnectionStringByName("concurs"));
        var sampleRepository = new SampleRepository(props);
        var childRepository = new ChildRepository(props);
        var organizingRepository = new OrganizingRepository(props);
        var registrationRepository = new RegistrationRepository(props,sampleRepository,childRepository);
        var child1 = new Child("Denisa", 7);
        //Child result = childRepository.Save(child1);
        //child1.Id = result.Id;
        try
        {
            Organizing organizing1 = organizingRepository.FindByName("organizator1", "org1");
            Organizing organizing2 = organizingRepository.FindByName("organizator2","org2");
            Console.WriteLine(organizing1.Name);
            Console.WriteLine(organizing2.Name);
            IEnumerable<Organizing> organizingList=organizingRepository.FindAll();
            foreach (var org in organizingList)
            {
                Console.WriteLine(org.Name);
            }
           
        } catch (Exception ex)
        {
            // Tratarea excepției
            // De obicei, aici se afișează mesajul de eroare sau se efectuează alte operații pentru a gestiona excepția
            Console.WriteLine("A apărut o excepție: " + ex.Message);
        }
        try {

            Sample sample1 = sampleRepository.FindOneByCategoryAndAge("Desen","6-8 ani");
            Registration registration = new Registration(child1,sample1);
            //registration=registrationRepository.save(registration);

            List<Child> children=registrationRepository.ListChildrenForSample(sample1);
            int no=registrationRepository.NumberOfChildrenForSample(sample1);

            Console.WriteLine("Number of children for sample "+no);
            foreach (var child in children)
            {
                Console.WriteLine(child.Name);
            }
        } catch (Exception e) {
            Console.WriteLine("Error getting children "+e);
        }

        ChildRepository childRepository2 = new ChildRepository(props);
    }
    static string GetConnectionStringByName(string name)
    {
        // Assume failure.
        string returnValue = null;

        // Look for the name in the connectionStrings section.
        ConnectionStringSettings settings =ConfigurationManager.ConnectionStrings[name];

        // If found, return the connection string.
        if (settings != null)
            returnValue = settings.ConnectionString;

        return returnValue;
    }
}