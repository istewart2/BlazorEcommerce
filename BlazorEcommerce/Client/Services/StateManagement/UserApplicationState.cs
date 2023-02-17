namespace BlazorEcommerce.Client.Services.StateManagement
{
    // can declare multiple state objects (like stores), doesn't need to be global
    // could also use DI to inject a state container service

    // we could persist this object in browser storage, but using protected browser storage
    // is only supported for blazor server
    public class UserApplicationState
    {
        public int CounterValue { get; set; } = 0;
    }
}
