IPersonManager customerManager = new CustomerManager();
//customerManager.Add();

IPersonManager employeeManager = new EmployeeManager();
//employeeManager.Add();

ProjectManager projectManager = new ProjectManager();
projectManager.Add(customerManager);
projectManager.Add(employeeManager);
projectManager.Add(new InternManager());



interface IPersonManager
{
    void Add();
    void Update();
}

class CustomerManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Müşteri eklendi.");
    }

    public void Update()
    {
        Console.WriteLine("Müşteri güncellendi.");
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Personel eklendi.");
    }

    public void Update()
    {
        Console.WriteLine("Personel güncellendi.");
    }
}

class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Stajer eklendi.");
    }

    public void Update()
    {
        Console.WriteLine("Stajyer güncellendi.");
    }
}
class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }
}