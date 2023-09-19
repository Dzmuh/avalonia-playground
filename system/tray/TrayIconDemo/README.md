# Avalonia Tray Icon Demo

Базовый пример добавления иконки приложения в системный трей.

По факту для визуального добавления мы добавляем в `App.axaml` следующий код:

```xml
<TrayIcon.Icons>
    <TrayIcons>
        <TrayIcon Icon="/Assets/avalonia-logo.ico" ToolTipText="Avalonia Tray Icon ToolTip">
            <TrayIcon.Menu>
                <NativeMenu>
                    <NativeMenuItem Header="Settings">
                        <NativeMenu>
                            <NativeMenuItem Header="Option 1" ToggleType="Radio" IsChecked="True" />
                            <NativeMenuItem Header="Option 2" ToggleType="Radio" IsChecked="True" />
                            <NativeMenuItemSeparator />
                            <NativeMenuItem Header="Option 3" ToggleType="CheckBox" IsChecked="True" />
                            <NativeMenuItem Icon="/Assets/avalonia-logo.ico" Header="Restore Defaults" />
                        </NativeMenu>
                    </NativeMenuItem>
                    <NativeMenuItem Header="Exit" />
                </NativeMenu>
            </TrayIcon.Menu>
        </TrayIcon>
    </TrayIcons>
</TrayIcon.Icons>
```

И всё. Потом можем обвязать всё логикой.
