#pragma checksum "C:\Users\PashinAS\source\repos\AppAnimals\AppAnimals\Views\Home\EditAnimal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb02ab6dac2926093fe55ee4e88bfd512966b37f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EditAnimal), @"mvc.1.0.view", @"/Views/Home/EditAnimal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/EditAnimal.cshtml", typeof(AspNetCore.Views_Home_EditAnimal))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\PashinAS\source\repos\AppAnimals\AppAnimals\Views\_ViewImports.cshtml"
using AppAnimals;

#line default
#line hidden
#line 2 "C:\Users\PashinAS\source\repos\AppAnimals\AppAnimals\Views\_ViewImports.cshtml"
using AppAnimals.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb02ab6dac2926093fe55ee4e88bfd512966b37f", @"/Views/Home/EditAnimal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2f28fe189d2800f9df9b230b9256a2208b162d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EditAnimal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(133, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(141, 113, true);
            WriteLiteral("    <h2>Edit animal</h2>\r\n    <br>\r\n    <script>\r\n        function getData() {\r\n            fetch(\"/api/Data/\" + ");
            EndContext();
            BeginContext(255, 5, false);
#line 11 "C:\Users\PashinAS\source\repos\AppAnimals\AppAnimals\Views\Home\EditAnimal.cshtml"
                            Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(260, 947, true);
            WriteLiteral(@").
                then(function (response) {
                    return response.json()
                }).
                then(data => {
                    var tr;

                    det = 1;
                    var aniData = data[0];
                    keysData = Object.keys(aniData);

                    for (let key in keysData) {
                        tr = $('<tr/>');
                        tr.append(""<td>"" + ""<b>"" + keysData[key] + "":&nbsp"" + ""</b>"" + ""</td>"");
                        tr.append(""<td>"" + ""<input id = '"" + keysData[key] + ""field' name='"" + keysData[key] + ""' type='text' value="" + ""'"" + aniData[keysData[key]] + ""'"" + "">"" + ""</td>"");
                        $(""table"").append(tr);
                    }
                    $('#Idfield').attr(""disabled"", ""disabled"");
                });
        }

        function MyFunc() {
            var answer = window.confirm(""Save data for Id: "" + ");
            EndContext();
            BeginContext(1208, 5, false);
#line 33 "C:\Users\PashinAS\source\repos\AppAnimals\AppAnimals\Views\Home\EditAnimal.cshtml"
                                                          Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(1213, 649, true);
            WriteLiteral(@" + "" ?"")
                if (answer) {
                    var obj = {};
                    var subObj = {};

                    inputData = $(""input"");

                    obj[inputData[1].getAttribute(""name"")] = inputData[1].value;

                    for (let i = 2; i !== inputData.length; i++) {
                        subObj[""Name""] = inputData[i].value;
                        obj[inputData[i].getAttribute(""name"")] = subObj;
                        subObj = {};
                    }
                    console.log(JSON.stringify(obj))
                    
                      const rawResponse = fetch(`/api/Data/${");
            EndContext();
            BeginContext(1863, 5, false);
#line 49 "C:\Users\PashinAS\source\repos\AppAnimals\AppAnimals\Views\Home\EditAnimal.cshtml"
                                                        Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(1868, 816, true);
            WriteLiteral(@"}`, {
                        method: 'PUT',
                        headers: {
                          'Accept': 'application/json',
                          'Content-Type': 'application/json'
                        },
                        body: JSON.stringify(obj)
                      });
                      const content = rawResponse;

                    console.log(content);

                    getData();
                
                }
                else {
                    //some code
                }
        }

        getData();
    </script>
    <table style=""border: 1px solid transparent"">
        <thead>
            <tr>
                <th></th>
                <th></th>
            </tr>
        </thead>
        <tbody></tbody>
    </table>
");
            EndContext();
            BeginContext(2686, 77, true);
            WriteLiteral("    <br>\r\n    <a href =\"\" onclick=\"MyFunc()\">Save</a>\r\n    <nobr> | </nobr>\r\n");
            EndContext();
            BeginContext(2768, 42, false);
#line 84 "C:\Users\PashinAS\source\repos\AppAnimals\AppAnimals\Views\Home\EditAnimal.cshtml"
Write(Html.ActionLink("Back", "Animals", "Home"));

#line default
#line hidden
            EndContext();
#line 84 "C:\Users\PashinAS\source\repos\AppAnimals\AppAnimals\Views\Home\EditAnimal.cshtml"
                                               ;

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
