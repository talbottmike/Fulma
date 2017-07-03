module Elements.Icon.State

open Elmish
open Types

let iconCode =
    """
```fsharp
    Icon.icon [ Icon.isSmall ]
        [ i [ ClassName "fa fa-home" ] [ ] ]
    Icon.icon [ ]
        [ i [ ClassName "fa fa-home" ] [ ] ]
    Icon.icon [ Icon.isMedium ]
        [ i [ ClassName "fa fa-home" ] [ ] ]
    Icon.icon [ Icon.isLarge ]
        [ i [ ClassName "fa fa-home" ] [ ] ]
```
    """

let init() =
    { Intro =
        """
# Icons

The **icons** can have different sizes and is also compatible with *[Font Awesome](http://fontawesome.io/)* icons.

*[Bulma documentation](http://bulma.io/documentation/elements/icon/)*
        """
      IconViewer = Viewer.State.init iconCode }

let update msg model =
    match msg with
    | IconViewerMsg msg ->
        let (viewer, viewerMsg) = Viewer.State.update msg model.IconViewer
        { model with IconViewer = viewer }, Cmd.map IconViewerMsg viewerMsg