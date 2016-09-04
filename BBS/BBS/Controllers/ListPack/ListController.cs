using BBS.Infrastructure.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SyntacticSugar;
using BBS.Infrastructure.ViewModels;
using BBS.Infrastructure.DbModels;
using SqlSugar;
namespace BBS.Controllers.ListPack
{
    /// <summary>
    ///  主要是用来让你了解分层，不要太注重功能实现
    /// </summary>
    public class ListController : Controller
    {
        private DbService _service;
        public ListController(DbService service)
        {
            _service = service;
        }

        public ActionResult Index(string title, int pageIndex = 1, int pageSize = 5)
        {
            var model = new ResultModel<string, List<dnt_test_topics>, HtmlString, List<dnt_test_forums>>();
            _service.Command<Outsourcing>((db, o) =>
            {
                model.ResultInfo = "增删查改";
                var queryable = o.GetQueryable(title);//处理查询逻辑
                queryable.DB = db;//设置连接对象
                int pageCount = queryable.Count();
                model.ResultInfo2 = queryable.ToPageList(pageIndex, pageSize);
                model.ResultInfo3 = o.GetPageString(pageIndex, pageSize, pageCount);//获取分页字符串
                model.ResultInfo4 = db.Queryable<dnt_test_forums>().ToList();//编辑用到的分类下拉列表
            });
            return View(model);
        }


        public JsonResult Delete(int id)
        {
            ResultModel<dynamic> model = new ResultModel<dynamic>();
            _service.Command<Outsourcing>((db, o) =>
            {
                model.IsSuccess = model.ResultInfo = db.Delete<dnt_test_topics, int>(id);
                //减少了2个类的冗余代码,这就是和传统三层最大区别
            });
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetById(int id)
        {
            ResultModel<dynamic> model = new ResultModel<dynamic>();
            _service.Command<Outsourcing>((db, o) =>
            {
                model.ResultInfo = db.Queryable<dnt_test_topics>().Single(it => it.tid == id);
                model.IsSuccess = true;
            });
            return Json(model, JsonRequestBehavior.AllowGet);
        }


        public JsonResult Insert(dnt_test_topics obj)
        {
            ResultModel<dynamic> model = new ResultModel<dynamic>();
            _service.Command<Outsourcing>((db, o) =>
            {
                obj.postdatetime = DateTime.Now;
                obj.lastpost = DateTime.Now;
                obj.lastposter=obj.poster = "管理员";
                model.ResultInfo = db.Insert(obj);
                model.IsSuccess = true;

            });
            return Json(model, JsonRequestBehavior.AllowGet);
        }


        public JsonResult Update(dnt_test_topics obj)
        {
            ResultModel<dynamic> model = new ResultModel<dynamic>();
            _service.Command<Outsourcing>((db, o) =>
            {
                model.IsSuccess = model.ResultInfo = db.Update<dnt_test_topics>(
                    new { title = obj.title, fid = obj.fid }
                    , it => it.tid == obj.tid);

            });
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}