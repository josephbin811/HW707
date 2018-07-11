# HW707
執行方式:

Ctrl+ F5 到 MyHome  Ex: http://localhost:9484/MyHome/




設計說明:

1. 開MVC範本

2. 將MoneyTemplate.html 更名為 _MoneyTemplate.cshtml 並放到shard底下

3. 修改_MoneyTemplate.cshtml, 將原本預設的清單用 sectioin包住, 並加上RenderSection,RenderBody()
   @section list{}
   @RenderSection("list", required: false)
   @RenderBody()

4. 在Models下新增資料夾 ViewModels, 並再新增 CashFlowModel class
   並增加對應的屬性

   public class CashFlowModel
    {
        public string flowType { get; set; }
        public string flowDate { get; set; }
        public string flowAmount { get; set; }
    }


5. 新增controller "MyHomeController", 新增index檢視; 並在index.cshtml增加layout
   @{
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_MoneyTemplate.cshtml";
   }

    
6. 在 "MyHomeController"下, 新增subAction "SubCashFlow" 並增加 50筆虛擬資料以及
   加入viewdata; 並新增view(partial) SubCashFlow.cshtml,以及在裡面加上table顯示
   50筆資料

7. 在index.cshtml 加入 @Html.Action("SubCashFlow")


    
   
