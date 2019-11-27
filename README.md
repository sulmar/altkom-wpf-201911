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
### ListView
### DataGrid


## Style (Styles)
### Utworzenie stylu
### Dziedziczenie stylu

## Szablony (Templates)

### Szablon danych (DataTemplate)

### Szablon kontrolek (ControlTemplate)

## Zasoby (Resources)
### Zasoby statyczne
### Zasoby dynamiczne
### Zasoby okna
### Zasoby aplikacji

## Wiązanie danych (Binding)
### Wiązanie kontrolek między sobą (Element Binding)
### Wiązanie kontrolek z danymi (DataBinding)
### Kontekst danych (DataContext)
### Typy wiązania danych

- TwoWay
- OneWay
- OneTime
- OneWayToSource

### Implementacja notyfikacji (INotifyPropertyChanged)

## Konwertery
### Konwerter wartości (IValueConverter)
### Konwerter wielowartościowy (IMultiValueConverter)


## Wyzwalacze (Triggers)
### Wyzwalacze właściwości
### Wyzwalacze danych

## MVVM


