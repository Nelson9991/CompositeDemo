using Composite.Core.Implementations;
using Composite.Core.Interfaces;

ICorporationFactory corporationFactory = new DefaultCorporationFactory(
    new ConsoleCompositePresenter()
);

var compositeDataStructure = corporationFactory.Create();
var output = compositeDataStructure.Display();

Console.WriteLine(output);
