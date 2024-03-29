﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanDoCongNghe.Models;

namespace WebBanDoCongNghe.Controllers
{
    public class SearchController : Controller
    {
        DBQuanLyBanDoCongNgheEntities db = new DBQuanLyBanDoCongNgheEntities();
        [HttpPost]
        public ActionResult KetQuaTimKiem(FormCollection form)
        {
            String sTuKhoa = form["InputTimKiem"].ToString();
            List<tb_Product> listKQTL = db.tb_Product.Where(n => n.TenSanPham.Contains(sTuKhoa)).ToList();
            return View(listKQTL.OrderBy(n => n.TenSanPham).ToList());
        }
        [HttpGet]
        public ActionResult KetQuaTimKiem(string sTuKhoa)
        {
            List<tb_Product> listKQTL = db.tb_Product.Where(n => n.TenSanPham.Contains(sTuKhoa)).ToList();
            return View(listKQTL.OrderBy(n => n.TenSanPham).ToList());
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (db != null)
                    db.Dispose();
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}