using Microsoft.AspNetCore.Mvc; 
using UserProva.Models; 

namespace UserProva.Controllers 
{
    [ApiController]  

    // Recebe toda a requisição, processa e retorna mensagem ao usuário 
    public class UserController : ControllerBase 
    {
        static List<User> lista = new List<User>(); 
        
        [Route("user")]
        [HttpGet] 
        public ActionResult Read() 
        {
            return Ok(lista); 
        }

        [Route("user")]
        [HttpPost] 
        public ActionResult Create(User user) 
        {
            user.UserId = Guid.NewGuid(); 
            lista.Add(user); 

            return Created(user.UserId.ToString(), user);
        }

        [Route("login")] 
        [HttpGet] 
        public ActionResult Login(string Email, string Password) 
        {
            foreach (User u in lista) 
            {
                if (u.Email == Email && u.Password == Password) 
                {
                    return Ok(u); 
                }
            } 
            return NotFound();
        }
    }
}