using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyFlores.Models;
using ProyFlores.Models.ViewModelsBloque;

namespace ProyFlores.Controllers
{
    public class producbloqueController : Controller
    {
        // GET: producbloque
        public ActionResult RegistroBloque()
        {
            List<ListBloqueViewModel> lst;
            using (proyectofloresEntities db = new proyectofloresEntities())
            {
                lst = (from d in db.probloque
                           select new ListBloqueViewModel
                           {
                               Idbloque = d.idbloque,
                               Numerobloque = d.numerobloque,
                               Presupuestadoaño = d.presupuestadoaño,
                               Llevamosaño = d.llevamosaño,
                               Diferenciaaño = d.diferenciaaño,
                               Presupuestadomes = d.presupuestadomes,
                               Llevamosmes = d.presupuestadomes,
                               Diferenciames = d.diferenciames,
                               Cedula = d.cedula,
                               Idinvernadero = d.idinvernadero

                           }).ToList();
            }

            return View(lst);
        }

        //registro nuevos bloques

        public ActionResult NuevoProdBloque()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NuevoProdBloque(BloqueViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using(proyectofloresEntities db = new proyectofloresEntities())
                    {
                        var oBloque = new probloque();
                        oBloque.idbloque = model.Idbloque;
                        oBloque.numerobloque = model.Numerobloque;
                        oBloque.presupuestadoaño = model.Presupuestadoaño;
                        oBloque.llevamosaño = model.Presupuestadoaño;
                        oBloque.diferenciaaño = model.Diferenciaaño;
                        oBloque.presupuestadomes = model.Presupuestadomes;
                        oBloque.llevamosmes = model.Llevamosmes;
                        oBloque.diferenciames = model.Diferenciames;
                        oBloque.cedula = model.Cedula;
                        oBloque.idinvernadero = model.Idinvernadero;

                        db.probloque.Add(oBloque);
                        db.SaveChanges();
                    }
                    return Redirect("~/producbloque/RegistroBloque");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        //editar bloque

        public ActionResult EditarBloque(int Id)
        {
            BloqueViewModel model = new BloqueViewModel();
            using (proyectofloresEntities db = new proyectofloresEntities())
            {
                var oBloque = db.probloque.Find(Id);
                model.Idbloque = oBloque.idbloque;
                model.Numerobloque = oBloque.numerobloque;
                model.Presupuestadoaño = oBloque.numerobloque;
                model.Llevamosaño = oBloque.llevamosaño;
                model.Diferenciaaño = oBloque.diferenciaaño;
                model.Presupuestadomes = oBloque.presupuestadomes;
                model.Llevamosmes = oBloque.llevamosmes;
                model.Diferenciames = oBloque.diferenciames;
                model.Cedula = oBloque.cedula;
                model.Idinvernadero = oBloque.idinvernadero;
            }
                return View(model);
        }

        [HttpPost]
        public ActionResult EditarBloque(BloqueViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (proyectofloresEntities db = new proyectofloresEntities())
                    {
                        var oBloque = db.probloque.Find(model.Idbloque);
                        oBloque.idbloque = model.Idbloque;
                        oBloque.numerobloque = model.Numerobloque;
                        oBloque.presupuestadoaño = model.Presupuestadoaño;
                        oBloque.llevamosaño = model.Presupuestadoaño;
                        oBloque.diferenciaaño = model.Diferenciaaño;
                        oBloque.presupuestadomes = model.Presupuestadomes;
                        oBloque.llevamosmes = model.Llevamosmes;
                        oBloque.diferenciames = model.Diferenciames;
                        oBloque.cedula = model.Cedula;
                        oBloque.idinvernadero = model.Idinvernadero;

                        db.Entry(oBloque).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    return Redirect("~/producbloque/RegistroBloque");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //eliminar bloque

        public ActionResult EliminarBloque(int Id)
        {

            using (proyectofloresEntities db = new proyectofloresEntities())
            {
                var oBloque = db.probloque.Find(Id);
                db.probloque.Remove(oBloque);
                db.SaveChanges();
                
            }
            return Redirect("~/producbloque/RegistroBloque");
        }

    }
}