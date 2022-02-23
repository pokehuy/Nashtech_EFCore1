using Microsoft.AspNetCore.Mvc;
using efcore.Services;
using efcore.Models;
namespace efcore.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private readonly ILogger<StudentController> _logger;
    private readonly IStudentService _istudentService;

    public StudentController(ILogger<StudentController> logger, IStudentService istudentService)
    {
        _logger = logger;
        _istudentService = istudentService;
    }

    [HttpGet]
    public List<StudentModel> GetAll(){
        return _istudentService.GetAll();
    }

    [HttpGet("{id}")]
    public StudentModel Get(int id){
        return _istudentService.Get(id);
    }
    
    [HttpPost]
    public void Create(StudentModel student){
        _istudentService.Create(student);
    }

    [HttpPut("{id}")]
    public void Update(int id, StudentModel student){
        _istudentService.Update(id, student);
    }

    [HttpDelete("{id}")]
    public void Delete(int id){
        _istudentService.Delete(id);
    }
}