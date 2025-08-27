using Microsoft.Extensions.DependencyInjection;
using ScopedVmBundleClean;
using ScopedVmBundleClean.Services;

var services = new ServiceCollection();
services.TestViewModelServices();
var provider = services.BuildServiceProvider();

Console.WriteLine("--- ViewModel 1: Standard ---");
var viewModel1 = provider.GetRequiredService<TestViewModel>();
Console.WriteLine($"Initial state: Text='{viewModel1.Text ?? "null"}', Error='{viewModel1.Error ?? "none"}'");

viewModel1.LoadTextCommand.Execute(null);
Console.WriteLine($"After: Text='{viewModel1.Text}', Error='{viewModel1.Error ?? "none"}'");

viewModel1.ValidateTextCommand.Execute(null);
Console.WriteLine($"After Validate (no error): Text='{viewModel1.Text}', Error='{viewModel1.Error ?? "none"}'");

Console.WriteLine("\n--- ViewModel 2: Error ---");
var viewModel2 = provider.GetRequiredService<TestViewModel>();

viewModel2.SetText("Hi");
Console.WriteLine($"Text set to: '{viewModel2.Text}'");

viewModel2.ValidateTextCommand.Execute(null);
Console.WriteLine($"After Validate (with error): Text='{viewModel2.Text}', Error='{viewModel2.Error ?? "none"}'");
