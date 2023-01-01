# space-colonisation-sim
A text-based video game developed in C#. Simulates intelligent life's exploration of the cosmos.

## To run

In VS Code: install dotNet and run in terminal `dotnet run`.

## Game Mechanics

### 1. Civilization setup (select starting world) set intro text, solar system generators etc
### 1.1 Starting civilisation choices
 - `The Re-United Nations of Earth`: By the late 23rd century humanity has weathered climate change, wars and Kessler syndrome and emerged stronger. The many peoples of the Planet Earth have united and ventured forth to explore their native Sol system.
 - `The Shigu Imperium`: Consisting predominantly Northern Sergals hailing from the Vilous system; the Shigu Imperium has risen from the collapse of world peace on the planet Tal. Having reached its limits on its hostile homeworld the empire looks to the stars for further expansion plans.
 - `The Enlightened Kingdom of Gold Ring`: Lying across the wastes of Southern Deserts lies the prosperous mega city of Gold Ring. Made up of the Sergals, Agudner and Nevreans hailing from the Planet Tal the Kingdom's current ruler has experienced a divine revalation and seeks to head towards the brightest starts in search of revelation.

### 1.2. Map (start planet -> solar system -> neighbouring systems etc).

### 2. Mining (bring back excess fuel, minerals, water).

### 3. Create and deploy colonies.

## Technical decisions

### Saving and loading game data

Currently save data is stored by reading and writing from a `.json` file which is saved locally. THis decision was made for ease of development. If this system is not robust enough as this project progresses it will be replaced with a SQL database.
