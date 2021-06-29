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
            /*
            GetItemsss mylist = new GetItemsss();
            mylist.name = item.Fields["tags"].Value;
            tag.Add(mylist);*/

            /*/ Sitecore.Data.Fields.MultilistField multilistField = item.Fields["MyMultiiistField"];
              if (multilistField != null)
              {
                  foreach (Sitecore.Data.Items.Item city in multilistField.GetItems())
                  {
                      //gitem.Pagecollection = city.Name;
                      ViewBag.Name = city.Name;
                      //   gitem = city.Name.ToList();
                  }
              }*/

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
                    //gitem.Pagecollection = city.Name;
                    mytags += "|"+city.Name;
                    //   gitem = city.Name.ToList();
                }
            }
            List<GetItemsss> tag = new List<GetItemsss>() { new GetItemsss() { name = mytags } };
            /*
            GetItemsss mylist = new GetItemsss();
            mylist.name = item.Fields["tags"].Value;
            tag.Add(mylist);*/

            /*/ Sitecore.Data.Fields.MultilistField multilistField = item.Fields["MyMultiiistField"];
              if (multilistField != null)
              {
                  foreach (Sitecore.Data.Items.Item city in multilistField.GetItems())
                  {
                      //gitem.Pagecollection = city.Name;
                      ViewBag.Name = city.Name;
                      //   gitem = city.Name.ToList();
                  }
              }*/

            return View("~/Views/Article/DobleComponent.cshtml", tag);
        }

       /*private List<GetItems> GetAllItems()
        {
            return new List<GetItems>()
            {
             item = Sitecore.Context.Database.GetItem("{742CDABD-A4AE-49B5-B297-32C4BD7EC75E}")

        };
        
        }*/

    }
}