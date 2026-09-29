using Microsoft.AspNetCore.Mvc;

namespace MvcBasicSample.Controllers;

 //URLのHelloに太陽する要素を受け取るController
public class HelloController : Controller {

      // ../Hello/Indexで呼び出されるAction
      
public IActionResult Index() {
        //Viewを使用せず文字列をHTTPの応答として返す
        return Content("初めてのASP.NET.Core");
     }
    }

