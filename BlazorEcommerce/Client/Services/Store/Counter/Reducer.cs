using Fluxor;

namespace BlazorEcommerce.Client.Services.Store.Counter
{
    public class Reducer
    {
        [ReducerMethod]
        public static CounterState ReduceIncrementCounterAction(CounterState state, IncrementCounterAction action) =>
            new CounterState(clickCount: state.ClickCount + 1);
    }
}
