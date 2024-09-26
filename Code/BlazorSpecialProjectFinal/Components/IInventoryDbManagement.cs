using BlazorSpecialProjectFinal.Objects;

namespace BlazorSpecialProjectFinal.Components
{
    public interface IInventoryDbManagement
    {
        List<Sweet> GetSweets();

        Sweet? GetSweetById(int id);


    }
}