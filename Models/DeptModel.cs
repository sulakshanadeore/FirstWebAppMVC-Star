namespace FirstWebAppMVC_Star.Models
{
    public class DeptModel
    {

        public int Deptno { get; set; }
        public string   Dname { get; set; }
        public string Loc { get; set; }

        public List<EmployeeModel> GetAllEmps { get; set; }
    }
}
