using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistence.Repository;
using Service.CRUD;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Test.Persistence;


namespace Web.Api.Test
{
    [TestClass]
    public class ToysSericeTest
    {
       
        [TestMethod]
        public void TryAddNewToyTest()
        {
            // Preparación
            var context = ApplicationDbContextInMemory.Get();
            var genericRepository = new GenericRepository<PlayThing>(context);
            var service = new GenericService<PlayThing>(genericRepository);

            var newSalary = new PlayThing
            {
                Id = 1,
                Nombre = "Juguete de prueba",
                Compania = " Matell",
                Precio = 20.50m,
                RetriccionEdad = 10,
                Descripcíon = "Descripcion de pruba",
                Imagen = ""
            };
            // Prueba
      
            service.Insert(newSalary);

            var result = service.GetById(newSalary.Id);

            // Verificación
            Assert.AreEqual(newSalary.Nombre, result.Nombre);
            context.Database.EnsureDeleted();


        }


        [TestMethod]
        public async Task TryOpdateToyTest()
        {

            // Preparación
            var context = ApplicationDbContextInMemory.Get();
            var genericRepository = new GenericRepository<PlayThing>(context);
            var service = new GenericService<PlayThing>(genericRepository);

            context.PlayThing.Add(new PlayThing
            {
                Nombre = "Juguete de prueba 1",
                Compania = " Matell",
                Precio = 20.50m,
                RetriccionEdad = 10,
                Descripcíon = "Descripcion de pruba",
                Imagen = ""

            });

            context.PlayThing.Add(new PlayThing
            {
                Nombre = "Juguete de prueba 2",
                Compania = " Matell",
                Precio = 20.50m,
                RetriccionEdad = 10,
                Descripcíon = "Descripcion de pruba",
                Imagen = ""

            });

            context.PlayThing.Add(new PlayThing
            {
                Nombre = "Juguete de prueba 3",
                Compania = " Matell",
                Precio = 20.50m,
                RetriccionEdad = 10,
                Descripcíon = "Descripcion de pruba",
                Imagen = ""

            });

            context.SaveChanges();

            PlayThing item = service.GetById(2);
            var cambio = "Juguete actualizado";
            item.Nombre = cambio;

            // Prueba
            service.Update(item);

            PlayThing itemUpdate = service.GetById(2);

            // Verificación
            Assert.AreEqual(cambio, itemUpdate.Nombre);
            context.Database.EnsureDeleted();
        }

        [TestMethod]
        public async Task TryGetAllTest()
        {

            // Preparación
            var context = ApplicationDbContextInMemory.Get();
            var genericRepository = new GenericRepository<PlayThing>(context);
            var service = new GenericService<PlayThing>(genericRepository);
            context.PlayThing.Add(new PlayThing
            {
                Nombre = "Juguete de prueba 1",
                Compania = " Matell",
                Precio = 20.50m,
                RetriccionEdad = 10,
                Descripcíon = "Descripcion de pruba",
                Imagen = ""

            });

            context.PlayThing.Add(new PlayThing
            {
                Nombre = "Juguete de prueba 2",
                Compania = " Matell",
                Precio = 20.50m,
                RetriccionEdad = 10,
                Descripcíon = "Descripcion de pruba",
                Imagen = ""

            });

            context.SaveChanges();

            // Prueba
            var result =  service.GetAll();

            // Verificación
            Assert.AreEqual(2, result.Count());
            context.Database.EnsureDeleted();
        }

        [TestMethod]
        public async Task TryGetToyByIdTest()
        {
            // Preparación
            var context = ApplicationDbContextInMemory.Get();
            var genericRepository = new GenericRepository<PlayThing>(context);
            var service = new GenericService<PlayThing>(genericRepository);

            context.PlayThing.Add(new PlayThing
            {
                Nombre = "Juguete de prueba 1",
                Compania = " Matell",
                Precio = 20.50m,
                RetriccionEdad = 10,
                Descripcíon = "Descripcion de pruba",
                Imagen = ""

            });

            context.PlayThing.Add(new PlayThing
            {
                Nombre = "Juguete de prueba 2",
                Compania = " Matell",
                Precio = 20.50m,
                RetriccionEdad = 10,
                Descripcíon = "Descripcion de pruba",
                Imagen = ""

            });

            context.PlayThing.Add(new PlayThing
            {
                Nombre = "Juguete de prueba 3",
                Compania = " Matell",
                Precio = 20.50m,
                RetriccionEdad = 10,
                Descripcíon = "Descripcion de pruba",
                Imagen = ""

            });


            context.SaveChanges();

            // Prueba
            var result =  service.GetById(3);

            // Verificación
            Assert.AreEqual("Juguete de prueba 3", result.Nombre);


            context.Database.EnsureDeleted();
        }


        [TestMethod]
        public async Task TryDeleteToyTest()
        {
            // Preparación
            var context = ApplicationDbContextInMemory.Get();
            var genericRepository = new GenericRepository<PlayThing>(context);
            var service = new GenericService<PlayThing>(genericRepository);

            context.PlayThing.Add(new PlayThing
            {
                Nombre = "Juguete de prueba 1",
                Compania = " Matell",
                Precio = 20.50m,
                RetriccionEdad = 10,
                Descripcíon = "Descripcion de pruba",
                Imagen = ""

            });

            context.PlayThing.Add(new PlayThing
            {
                Nombre = "Juguete de prueba 2",
                Compania = " Matell",
                Precio = 20.50m,
                RetriccionEdad = 10,
                Descripcíon = "Descripcion de pruba",
                Imagen = ""

            });

            context.PlayThing.Add(new PlayThing
            {
                Nombre = "Juguete de prueba 3",
                Compania = " Matell",
                Precio = 20.50m,
                RetriccionEdad = 10,
                Descripcíon = "Descripcion de pruba",
                Imagen = ""

            });


            context.SaveChanges();

            // Prueba
            service.Delete(1);

            var result = service.GetAll();

            // Verificación
            Assert.AreEqual(2, result.Count());


            context.Database.EnsureDeleted();
        }


        [TestMethod]
        public async Task TryGetAllToyPaginigTest()
        {

            // Preparación
            var context = ApplicationDbContextInMemory.Get();
            var genericRepository = new GenericRepository<PlayThing>(context);
            var service = new GenericService<PlayThing>(genericRepository);
            context.PlayThing.Add(new PlayThing
            {
                Nombre = "Juguete de prueba 1",
                Compania = " Matell",
                Precio = 20.50m,
                RetriccionEdad = 10,
                Descripcíon = "Descripcion de pruba",
                Imagen = ""

            });

            context.PlayThing.Add(new PlayThing
            {
                Nombre = "Juguete de prueba 2",
                Compania = " Matell",
                Precio = 20.50m,
                RetriccionEdad = 10,
                Descripcíon = "Descripcion de pruba",
                Imagen = ""

            });
            context.PlayThing.Add(new PlayThing
            {
                Nombre = "Juguete de prueba 3",
                Compania = " Matell",
                Precio = 20.50m,
                RetriccionEdad = 10,
                Descripcíon = "Descripcion de pruba",
                Imagen = ""

            });

            context.SaveChanges();

            //// Default parameters
            int page = 1;
            int take = 10;

            // Prueba
            var result = service.GetPaging(page,take);

            // Verificación
            Assert.AreEqual(3, result.Total);

            Assert.AreEqual(page, result.Page);

            context.Database.EnsureDeleted();
        }
    }
}

