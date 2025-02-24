using AzureCostCli.CostApi;

namespace AzureCostCli.Commands.ShowCommand.OutputFormatters;

public abstract class BaseOutputFormatter
{
    public abstract Task WriteAccumulatedCost(AccumulatedCostSettings settings,AccumulatedCostDetails accumulatedCostDetails);

    public abstract Task WriteCostByResource(CostByResourceSettings settings, IEnumerable<CostResourceItem> resources);
}

public record AccumulatedCostDetails( 
    Subscription Subscription,
    IEnumerable<CostItem> Costs,
    IEnumerable<CostItem> ForecastedCosts,
    IEnumerable<CostNamedItem> ByServiceNameCosts,
    IEnumerable<CostNamedItem> ByLocationCosts,
    IEnumerable<CostNamedItem> ByResourceGroupCosts);