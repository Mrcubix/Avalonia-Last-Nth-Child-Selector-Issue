# The Issue At Hand

The last element of this list is supposed to have a margin of 0 in order to not show the scrollbar
until the 15th element is added.

However, both :last-child & nth-last-child(1) are not working properly and the later seems to only be evaluated at initial render.

![image](https://github.com/AvaloniaUI/Avalonia/assets/39861216/caa5a00a-77d4-467d-a4c2-6fcd3a199a8b)

Discussion Link: https://github.com/AvaloniaUI/Avalonia/discussions/12147