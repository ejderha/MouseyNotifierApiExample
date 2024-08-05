# Mousey Notifier Api Example
Mousey Notifier API Example project, all you need to make the Mousey Notifier work for your projects.

This is the example MVC (ASP.Net) api project for the Mousey Notifier integration.

Mousey is a client app that can reduce RSI and boost your computer experience by combining and exposing windows features to your mouse 
location. It's a handy app for every day's work. You can download the app for your devices on http://mousey.forservices.net 
(it will on the windows appstore very soon).

Another great feature is that, it can interact with your backend (API) services for data fetching and command executions on client devices.
For example you can start websites/portals/landing pages or execute windows commands on the client devices, 
commands can also be interperted by Cortana, have a look at https://mouseyv3.azurewebsites.net/Home/HowTo#notifier.

Handy use case(s)/example command automation:
> AEX stock (cortana results).

> Create appointments from your projects.

> Manage workload for your app users.

> Start web links/standalone apps from your projects.

> Automate Office 365 actions from your projects.

The endpoints can be configured on the Mousey App itself.

The example project returns a simple one result containing the required data. You can fetch your data from any desired location, userid 
is passed by url parameter for user specific data results if required.

Source code:
To start integrading have a look to the MouseyNotifyController.cs, the Get method explains everything you need to know for 
returning your results. I have also included the Forservices.Mousey.Model.csproj for returning the right result type.

All project are set on .Net Framework 4.6.2, you can downgrade if needed. This project is open source any contribution is welcome for 
example db storage or esb/msmq integration, or user load distribution of dataitems (notifications).

For more information about the notifier please visit the following website https://mouseyv3.azurewebsites.net/Home/HowTo#notifier.
