using AutoMapper;
using Common.Collection;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.CRUD;
using Service.CRUD.DTO_s;
using Web.Api.Store.Utils;

namespace Web.Api.Store.Controllers
{
    /// <summary>
    /// Controlller Toys
    /// </summary>   
    [ApiController]
    [Route("/toys")]
    //salaries
    public class ToysController: ControllerBase
    {
        private readonly IGenericService<PlayThing> _toy;
        private readonly IMapper _mapper;
        /// <summary>
        /// Constructor Toys
        /// </summary>  
        public ToysController(IGenericService<PlayThing> toy, IMapper mapper)
        {
            _toy = toy;
            _mapper = mapper;
        }

        /// <summary>
        /// Get Toys and paging data
        /// </summary>         
        /// <param name="page">This  parameter define  the number of page to show</param>
        /// <param name="take">This parameter define how much item you want to get</param>
        /// <response code="200">OK. Devuelve el objeto solicitado.</response>        
        /// <response code="404">NotFound. No se ha encontrado el objeto solicitado.</response> 
        //salarystimate
        [HttpGet("GetPaging")]
        public DataCollection<ToyDTO> GetPaging(int page = 1, int take = 10)
        {
            var toys = _toy.GetPaging(page, take);
            return _mapper.Map<DataCollection<ToyDTO>>(toys);
        }

        /// <summary>
        /// Get Toy by Id
        /// </summary>         
        /// <param name="id">This  parameter find in toy by id</param>
        /// <response code="200">OK. Devuelve el objeto solicitado.</response>        
        /// <response code="404">NotFound. No se ha encontrado el objeto solicitado.</response> 
        [HttpGet("GetbyId")]
        public ToyDTO GetbyId(int id)
        {
            var toy = _toy.GetById(id);
            if (!string.IsNullOrEmpty(toy.Imagen))
                toy.Imagen = ImageTool.GetBase64ByUrl(toy.Imagen);
            return _mapper.Map<ToyDTO>(toy); 
        }

        /// <summary>
        /// Post method for create new toy
        /// </summary>         
        /// <param name="model">Object data for create a toy</param>
        /// <response code="200">OK. Devuelve el objeto solicitado.</response>        
        /// <response code="404">NotFound. No se ha encontrado el objeto solicitado.</response> 
        [HttpPost]
        public IActionResult Create(ToyDTO model)
        {
            if(!string.IsNullOrEmpty(model.Imagen))
                model.Imagen = ImageTool.SaveImage(model.Imagen, HttpContext.Request.Host.ToString());
            var newToy = _mapper.Map<PlayThing>(model);
            _toy.Insert(newToy);

            return Ok();
        }

        /// <summary>
        /// Put method for update a existing toy
        /// </summary>         
        /// <param name="model">Object data for update a toy</param>
        /// <response code="200">OK. Devuelve el objeto solicitado.</response>        
        /// <response code="404">NotFound. No se ha encontrado el objeto solicitado.</response> 
        [HttpPut]
        public IActionResult Update(ToyDTO model)
        {
            if (!string.IsNullOrEmpty(model.Imagen))
                model.Imagen = ImageTool.SaveImage(model.Imagen, HttpContext.Request.Host.ToString());

            var newToy = _mapper.Map<PlayThing>(model);
            _toy.Update(newToy);

            return Ok();
        }
        /// <summary>
        /// Delete method for delete toy
        /// </summary>         
        /// <param name="id">param for find toy and delete</param>
        /// <response code="200">OK. Devuelve el objeto solicitado.</response>        
        /// <response code="404">NotFound. No se ha encontrado el objeto solicitado.</response> 
        [HttpDelete]
        public IActionResult Delete(int id)
        {
             _toy.Delete(id);
            return Ok();
        }

    }
}
