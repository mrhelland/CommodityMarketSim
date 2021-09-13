# CommodityMarketSim

The purpose of this simulator is to demonstrate the effects of supply and demand on prices and its impact on decision-making. Teams will create a Bill of Materials needed to complete a task. Each team purchases 1 unit each round. At the end of each round, prices will adjust to reflect demand and relative supply.
![Screenshot](https://i.imgur.com/0Rgwo9d.png)

Current status of this project:
- Stable
- Windows Forms
- .NET 4.72
- Database not implemented (teams and commodities are currently hardcoded arrays)
- Generates HTML purchasing reports (using a template) at market close

The scope of this project was significantly retracted since: 
- It was needed for an activity in my robotics class several days later
- I could only use spare time to work on it

The application is a functional windows forms application, but the algorithms and data management are in need of further work.

Originally, the ultimate goal was to port this to a SignalR ASP.net application. But running this as a single app with the whole class has produced an interesting dynamic that would be hard to duplicate if each team accessed the application directly.



