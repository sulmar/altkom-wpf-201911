# WPF (Windows Presentation Foundation)

## XAML

- XML + {markup extension} = XAML

###  Atrybuty i elementy

- Zawartość taga
~~~ xaml
 <Button>Hello World</Button>
~~~ 

Zawartość pomiędzy tagami trafia do domyślnej właściwości. W przypadku kontrolki **ContentControl** jest to właściwość **Content**.

- Za pomocą atrybutu
~~~ xaml
 <Button Content="Hello World" />
~~~


- Za pomocą elementu
~~~ xaml
 <Button>
    <Button.Content>
        Hello World
    </Button.Content>
</Button>
~~~

- Praktyczne zastosowanie

~~~ xaml
 <Button Content="Send">
    <Button.Background>
        <LinearGradientBrush 
            StartPoint="0.0,0"
            EndPoint="1,0">
            <GradientStop Color="Green" Offset="0" />
            <GradientStop Color="Yellow" Offset="0.5" />
            <GradientStop Color="Red" Offset="1.0" />
        </LinearGradientBrush>
    </Button.Background>
 </Button>
~~~

### Markup Extensions

## Window i Page

### Window

Klasa **Window** jest samodzielnym widokiem. W Window nie można osadzić kolejnego Window, a jedynie otworzyć osobne okno.
~~~ xaml
<Window x:Class="WpfApp.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WpfApp"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <Grid>

    </Grid>
</Window>
~~~

### Page

Klasa **Page** nie jest samodzielnym widokiem. Musi być osadzony w Window za pomocą klasy **Frame**.

~~~ xaml
<Page x:Class="CustomersView"
      xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
      xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
      mc:Ignorable="d" 
      d:DesignHeight="450" d:DesignWidth="800"
      Title="CustomersView">
    <Grid>

    </Grid>
</Page>
~~~

~~~ xaml
<Window x:Class="WpfApp.ShellView"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WpfApp"
        mc:Ignorable="d"
        Title="Shell" Height="450" Width="800">
    <Grid>
             <Frame Source="CustomersView.xaml" />
    </Grid>
</Window>
~~~



## Panele (LayoutControl)

### Grid
~~~ xaml
    <Grid>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="1*" />
            <ColumnDefinition Width="3*" />     
        </Grid.ColumnDefinitions>

        <Grid.RowDefinitions>
            <RowDefinition Height="*" />
            <RowDefinition Height="Auto" />
        </Grid.RowDefinitions>
        
        <Button 
            Grid.Column="0"
            Width="200.5" Height="100" Background="Blue">Products</Button>
        <Button 
            Grid.Column="1" 
            Grid.Row="1"
            Grid.ColumnSpan="2"
            Width="300" Height="200" Background="Green">Customers</Button>
    </Grid>
~~~

### StackPanel
### DockPanel
### WrapPanel
### UniformGrid
### Canvas

## Kontrolki (ContentControl)
### Label
### TextBox
### Button
### CheckBox
### RadioButton
### Slider

## Kontrolki wieloelementowe (ItemsControl)

### ListBox
~~~ csharp
<ListBox ItemsSource="{Binding Path=Customers, Mode=OneWay}"
                 SelectedItem="{Binding SelectedCustomer}"
                 ItemTemplate="{StaticResource CustomerTemplate}" >
~~~

### ListView

~~~ csharp
<ListView ItemsSource="{Binding Path=Customers, Mode=OneWay}"
                 SelectedItem="{Binding SelectedCustomer}"
                 ItemTemplate="{StaticResource CustomerTemplate}" >
~~~



### ComboBox

~~~ csharp
<ComboBox ItemsSource="{Binding Path=Products, Mode=OneTime}"
                 SelectedItem="{Binding SelectedProduct}"
                 DisplayMemberPath="Name" >
~~~


### DataGrid

~~~ csharp
 <DataGrid ItemsSource="{Binding Customers}"
                  SelectedItem="{Binding SelectedCustomer}"
                  AutoGenerateColumns="False">
     <DataGrid.Columns>
         <DataGridTemplateColumn>
             <DataGridTemplateColumn.CellTemplate>
                 <DataTemplate>
                     <Image Style="{StaticResource ImageStyle}" Source="{Binding Photo}" />
                 </DataTemplate>
             </DataGridTemplateColumn.CellTemplate>
         </DataGridTemplateColumn>
         <DataGridTextColumn Header="Imię" Binding="{Binding FirstName}" />
         <DataGridTextColumn Header="Nazwisko" Binding="{Binding LastName}" />
         <DataGridTextColumn Header="Miasto" Binding="{Binding City}" />
         <DataGridCheckBoxColumn Binding="{Binding IsRemoved}" />
     </DataGrid.Columns>
</DataGrid>
~~~


## Style (Styles)

### Utworzenie stylu
~~~ xaml
<SolidColorBrush x:Key="MyBackgroundBrush" Color="blue" />
    <SolidColorBrush x:Key="MyForegroundBrush" Color="White" />

    <Style x:Key="DefaultButtonStyle" TargetType="Button">
        <Setter Property="Background" Value="{StaticResource MyBackgroundBrush}" />
        <Setter Property="Foreground" Value="{StaticResource MyForegroundBrush}" />
        <Setter Property="Width" Value="100" />
        <Setter Property="Height" Value="50" />
        <Setter Property="Margin" Value="5" />
        <Setter Property="FontSize" Value="20" />
    </Style>
~~~


### Styl dla danego typu
~~~ xaml
 <Style TargetType="Button" BasedOn="{StaticResource DefaultButtonStyle}">
    </Style>
~~~

### Dziedziczenie stylu

~~~ xaml

    <Style x:Key="CustomersButtonStyle" TargetType="Button"
               BasedOn="{StaticResource DefaultButtonStyle}"  >
        <Setter Property="Background" Value="Green" />
        <Setter Property="Width" Value="150" />
    </Style>
~~~


## Szablony (Templates)

### Szablon danych (DataTemplate)
~~~ xaml
 <DataTemplate x:Key="CustomerTemplate" DataType="{x:Type m:Customer}" >
     <StackPanel Orientation="Horizontal">
         <Image Source="{Binding Photo}" />
         <TextBlock Text="{Binding FirstName}" />
         <TextBlock Text="{Binding LastName}" />
         <TextBlock Text="{Binding City}" />
     </StackPanel>
 </DataTemplate>
 ~~~    
 
### Szablon kontrolek (ControlTemplate)

## Zasoby (Resources)
### Zasoby statyczne
### Zasoby dynamiczne
### Zasoby okna
### Zasoby aplikacji

## Wiązanie danych (Binding)
### Wiązanie kontrolek między sobą (Element Binding)
### Wiązanie kontrolek z danymi (DataBinding)

~~~ xaml
<StackPanel>
   <TextBox Text="{Binding SelectedCustomer.FirstName, UpdateSourceTrigger=PropertyChanged}" />
   <TextBox Text="{Binding SelectedCustomer.LastName}" />
   <TextBox Text="{Binding SelectedCustomer.FullName}" />
   <TextBox Text="{Binding SelectedCustomer.City}" />
   <CheckBox IsChecked="{Binding SelectedCustomer.IsRemoved}" />
   <Image Source="{Binding SelectedCustomer.Photo}" />
   <Button Command="{Binding PrintCommand }" Content="Print"  />
</StackPanel>
~~~

### Typy wiązania danych

- TwoWay
- OneWay
- OneTime
- OneWayToSource

### Implementacja notyfikacji (INotifyPropertyChanged)

~~~ csharp

protected abstract class Base : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
~~~

- Użycie

~~~ csharp

public class Customer : Base
{
    private string firstName;

    public string FirstName
    {
        get => firstName; 
        set
        {
            if (firstName != value)
            {
                firstName = value;
                OnPropertyChanged();
            }
        }
    }
~~~
#### Biblioteka Fody 
https://github.com/Fody/PropertyChanged



## Konwertery
### Konwerter wartości (IValueConverter)

~~~ csharp
public class BoolToVisibiltyConverter : MarkupExtension, IValueConverter
 {

     public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
     {
         bool isVisible = (bool)value;

         if (isVisible)
             return Visibility.Visible;
         else
             return Visibility.Collapsed;
     }

     public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
     {
         throw new NotImplementedException();
     }

     public override object ProvideValue(IServiceProvider serviceProvider)
     {
         return this;
     }
 }
 ~~~
 
 
 ~~~ xaml
<Button Content="Logout" Visibility="{Binding IsAuthenticated, Converter={c:BoolToVisibiltyConverter}}" />
 ~~~
 
### Konwerter wielowartościowy (IMultiValueConverter)


## Wyzwalacze (Triggers)
### Wyzwalacze właściwości
### Wyzwalacze danych

## MVVM

### Komendy (Commands)

~~~ csharp 
public class RelayCommand : ICommand
  {
      public event EventHandler CanExecuteChanged;

      //public event EventHandler CanExecuteChanged
      //{
      //    add { CommandManager.RequerySuggested += value; }
      //    remove { CommandManager.RequerySuggested -= value; }
      //}

      public void OnCanExecuteChanged()
      {
          this.CanExecuteChanged?.Invoke(this, EventArgs.Empty);
      }

      private readonly Action execute;
      private readonly Func<bool> canExecute;

      public RelayCommand(Action execute, Func<bool> canExecute = null)
      {
          this.execute = execute;
          this.canExecute = canExecute;
      }

      public bool CanExecute(object parameter)
      {
          return canExecute == null ? true : canExecute();
      }

      public void Execute(object parameter)
      {
          execute?.Invoke();
      }
  }
~~~
