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
### Implementacja notyfikacji (INotifyPropertyChanged)

## Konwertery
### Konwerter wartości (IValueConverter)
### Konwerter wielowartościowy (IMultiValueConverter)


## Wyzwalacze (Triggers)
### Wyzwalacze właściwości
### Wyzwalacze danych

## MVVM


