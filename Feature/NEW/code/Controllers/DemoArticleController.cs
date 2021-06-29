using DobleHelix.Feature.Article.Models;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq;
using Sitecore.ContentSearch.Linq.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace DobleHelix.Feature.Article.Controllers
{
    public class DemoArticleController : Controller
    {
        // GET: DemoArticle
        public ActionResult Index()
        {

            /* var item = Sitecore.Context.Database.GetItem("{167070A3-81D5-4289-9709-A430D7E32CDC}");
             ProductModel myProduct;
             var products = new List<ProductModel>();

             //Get current page 
             var currentPage = Sitecore.Context.Item;
             products =;*/
            return View();
        }
        public ActionResult DoblePostCard()
        {

            var item = Sitecore.Context.Database.GetItem("{167070A3-81D5-4289-9709-A430D7E32CDC}");
            string str = item.Fields["Copyright"].Value;
            string mytags1 = "";
            Sitecore.Data.Fields.MultilistField multilistField = item.Fields["PreferredArticles"];
            if (multilistField != null)
            {
                foreach (Sitecore.Data.Items.Item city in multilistField.GetItems())
                {
                    //gitem.Pagecollection = city.Name;
                    mytags1 += city.Name + "|";
                    //   gitem = city.Name.ToList();
                }
            }
            List<GetItemsss> mytagssss = new List<GetItemsss>() { new GetItemsss() { name = item.Fields["PreferredArticles"].Value } };
           

            return View("~/Views/Article/DoblepostCard.cshtml", mytagssss);
        }
        public ActionResult DobleComponent()
        {

            var item = Sitecore.Context.Database.GetItem("{167070A3-81D5-4289-9709-A430D7E32CDC}");
            string str = item.Fields["Copyright"].Value;
            string mytags = "";
            Sitecore.Data.Fields.MultilistField multilistField = item.Fields["tags"];
            if (multilistField != null)
            {
                foreach (Sitecore.Data.Items.Item city in multilistField.GetItems())
                {
                  
                    mytags += "|" + city.Name;
                 
                }
            }
            List<GetItemsss> tag = new List<GetItemsss>() { new GetItemsss() { name = mytags } };
       
            return View("~/Views/Article/DobleComponent.cshtml", tag);
        }

      

        

    }
}