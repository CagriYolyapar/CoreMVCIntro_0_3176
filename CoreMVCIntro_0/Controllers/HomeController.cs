using Microsoft.AspNetCore.Mvc;

namespace CoreMVCIntro_0.Controllers
{
    public class HomeController : Controller
    {
        //MVC'de Controller icerisinde olan metotlara biz Action deriz...

        //MVC'de Action'lar cok önemlidir...Cünük BackEnd işlemlerinizi, HTTP'ye göre vörev yapmak istediginiz tüm islemlerinizi Controller'daki Action'lar yapar...
        
        
        public IActionResult Index()
        {
            //View metodu icerisine bir argüman almadıysa , hangi metodun yasam alanında cagrılıyorsa o metodun isminde bir View arar...Yani su anda icinde bulundugu Action'in isminde bir View'i mimarinizin Views klasorunde, icinde bulundugu Controller ile aynı isimde bir klasorun icerisinde arayacaktır...Yani icinde bulundugu ACtion ile aynı isme sahip olan bir View'i döndürmeye calısır. Bu View'i da cagrıldıgı Action'in bulundugu Controller'in ismiyle aynı isimde bir klasorde (Views icerisinde) arar...
            return View();
        }

        public IActionResult Contact()
        {
            //Eger View metodunuz string bir argüman alıp baska bir View ismi söylerse dönen View o belirttiginiz isimdeki olur...
            return View();
        }


        //HomeController hc = new HomeController();
        // hc.Index();
    }

    //Tum GUn olsun :3 
    //Olmasın : 5
    //Yarım Gün 
}
