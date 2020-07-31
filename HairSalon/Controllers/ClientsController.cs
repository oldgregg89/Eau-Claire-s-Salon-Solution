using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;
    public DonationsController(HairSalonContext db)
    {
      _db = db;
    }
    public ActionResult Details( int id )
    {
      Client thisClient = _db.Clients.Include(Client => Client.Stylist).FirstOrDefault(clients => clients.ClientId == id);
      return View(thisClient);
    }
    public ActionResult Create()
    {
    ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
    return View();
    }
    public ActionResult Edit (int id)
    {
      var thisClient = _db.Clients.FirstOrDefault(Clients => Clients.ClientId == id);
      ViewBag.DonorId = new SalectList(_db.Stylists, "StylistId", "Name");
      return View(thisClient);
    }
    
  }
}