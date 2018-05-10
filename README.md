# Simple_Launcher_MVC
Launcher created as an example of MVC project architecture in WindowsForms application.

Basically, check for any pending updates, run them, and start the game you want.

It consists of 3 layers:

  - Launcher.View: Responsible for all graphic loader launcher;

  - Launcher.Presenter: This is the boot project and is responsible for all launcher logical loading, such as downloading updates, verifying authenticity of files, etc.

  - Launcher.CrossCutting: Contains information and architecture settings, which are used by all projects.

All layers are prepared for easy adaptation or refactoring.

Application created by: David Araujo
