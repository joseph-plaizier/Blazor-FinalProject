using BlazorSpecialProjectFinal.Objects;

namespace BlazorSpecialProjectFinal.Components
{
    public interface IInventoryDbManagement
    {
        List<Sweet> GetSweets();

        Sweet? GetSweetById(int id);

        void DeleteProduct(int Id);

        void UpdateProduct(int Id, Sweet product);

        void AddProduct(Sweet product);


    }
}