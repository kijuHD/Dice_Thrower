# Dice_Thrower

## Purpose
  
  In this project you will be able to create your own set of dices (D6,D12) to throw and see the results.

## Repository structure
  
  Most recent, playable version of project is on main branch. Work in progress code is on develop branch.

## Working features on main branch

  - Main menu with two buttons - Quick Start and Dice Sets
  - Dice Sets menu with one button - Back
  - Quick Start dice spawn

## How it works?

### Main menu 

- Quick Start - Turns off UI Overlay and starts "Gameloop" with QuickStartSet of Dices

- Dice Sets - Shows Dice Sets menu

### Dice Sets menu

Future menu for creating new and editing existing Dice Sets

- Back - Takes you back to Main menu

### "Gameloop"

- Quick Start - Starts the game with quick start set of Dices based of QuickStartSet scriptable object (Assets/Scripts/ScriptableObjects). Dices will spawn based on that set.

### Dice

For now you can only have six (D6) or twelve (D12) sided dices. Also there is no written logic for Throw or Select methods. Temporary dices are empty monobehaviours needed for testing the DiceSpawner.

### DiceSet

DiceSet.cs is a Scriptable Object consisting of two lists - List<DiceType> types and List<int> counts. First one defines type of dices in the set and the second one defines the number of dices per type. Because the menus for creating or editing dice sets are't created you can edit DiceSet via Unity's inspector. Every created DiceSet must be included in SetsCollection scriptable object. Make sure that there is only one set marked as QuickSet. If there will be more the first one on the list will be selected.

## Things to do in near future

  - Dice Sets menu - create, edit dice sets
  - Main menu Start button - spawn dices based on selected dice set
  - Basic dice throw
  - Dice reroll
  - UI for throwing dices
