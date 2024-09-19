using ReactiveUI;
using ReactiveUI.SourceGenerators;

namespace TestReactiveUiSourceGenBug2;

internal partial class TestViewModel : ReactiveObject
{
    [Reactive]
    private string? _test;
}
