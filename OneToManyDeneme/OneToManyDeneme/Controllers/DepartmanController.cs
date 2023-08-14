using Business.Layer.Interface;
using DataAcess.Layer.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OneToManyDeneme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmanController : ControllerBase
    {
        private readonly IDepartmanBusiness _departmanBusiness;
        public DepartmanController(IDepartmanBusiness departmanBusiness)
        {
            _departmanBusiness = departmanBusiness;
        }

        [HttpPost]
        public async Task<IActionResult> Post(string DNAME,string CNAME){

            var post=await _departmanBusiness.CreateDepartman(DNAME,CNAME);  
            return Ok(post);    
        }
        [HttpGet]
        public async Task<IActionResult>Get()
        {
            var get = await _departmanBusiness.GetAllDepartman();
            return Ok(get); 
        }

        [HttpPut]
        public async Task<IActionResult> Put(int DID,int CID, string name)
        {
            var put = await _departmanBusiness.UpdateDepartman(DID,CID,name);
            return Ok(put);
        }


        [HttpDelete]
        public async Task<IActionResult> Delete(int DID,int CID)
        {
            var dl = _departmanBusiness.DeleteDepartman(DID, CID);
            if(dl != null)
            {
                return  Ok(dl);
            }
            return BadRequest();

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetID(int id)
        {
            var get = await _departmanBusiness.GetDepartman(id);
            return Ok(get);
        }


    }
}

