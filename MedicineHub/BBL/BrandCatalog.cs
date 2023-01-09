namespace BBL;
using BOL;
using DAL;


public class BrandCatalog
{
      public List<Medicine> GetAllProducts(){
      List<Medicine> allProducts = new List<Medicine>();
      allProducts=DBManager.RetrieveMedicineData();
      return allProducts;
    }
}
