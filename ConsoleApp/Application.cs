namespace ConsoleApp
{
    public class Application
    {
        
        public Application(IPrintService<Employee> printService, IEmployeeService employeeService) 
        {
            PrintService = printService;
            EmployeeService = employeeService;
        }

        public IPrintService<Employee> PrintService { get; }
        public IEmployeeService EmployeeService { get; }

        public void Run()
        {
            var employee = EmployeeService.GetAll();
            PrintService.Print(employee);
        }
    }
}