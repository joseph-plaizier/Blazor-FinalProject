using BlazorSpecialProjectFinal.Objects;

namespace BlazorSpecialProjectFinal.Components
{
    public interface ICheckoutHistoryDbManagement
    {
        void AddHistory(QtPurchase cart, string userId);
    }
}
