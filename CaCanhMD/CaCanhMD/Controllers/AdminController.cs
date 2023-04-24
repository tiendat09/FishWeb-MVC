using CaCanhMD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaCanhMD.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        QLBanCaCanhDataContext db = new QLBanCaCanhDataContext();
        public ActionResult LayoutAdmin()
        {
            return View();
        }

        public ActionResult CaCanh()
        {
            if (Session["Admin"] == null)
            {
                return RedirectToAction("DangNhap", "DangNhap");
            }
            var listCaCanh = db.SanPhams.OrderBy(sp => sp.MaSP).ToList();
            return View(listCaCanh);
        }
  
        public ActionResult TrangPhucNu(int page = 1, int pageSize = 12)
        {
            if (Session["Admin"] == null)
            {
                return RedirectToAction("DangNhap", "DangNhap");
            }
            var trangPhucNu = new Product();
            var model = trangPhucNu.ListAll(page, pageSize);
            return View(model);
        }
        public ActionResult Thuoc(int page = 1, int pageSiza = 12)
        {
            if (Session["Admin"] == null)
            {
                return RedirectToAction("DangNhap", "DangNhap");
            }
            var listThuoc = db.SanPhams.OrderBy(sp => sp.MaSP).ToList();
            return View(listThuoc);
        }
        public ActionResult DanhMucCacSanPham(int page = 1, int pageSize = 12)
        {
            if (Session["Admin"] == null)
            {
                return RedirectToAction("DangNhap", "DangNhap");
            }
            var sanPham = new Product();
            var model = sanPham.ListAll(page, pageSize);
            return View(model);
        }

        public ActionResult DangXuat()
        {
            Session["Admin"] = null;
            return RedirectToAction("Home", "Home");
        }
    }
}