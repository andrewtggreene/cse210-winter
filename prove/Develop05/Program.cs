using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        /*
        @startuml
Goal <|-- EternalGoal
Goal <|-- SimpleGoal
Goal <|-- ChecklistGoal
User *-- Goal
class Goal{
# _name: string
# _description: string
# _points: int
+ Goal()

+ //DisplayGoal//(): string
+ //RecordEvent//(): void
+ //IsCompleted//(): void
+ //GetSaveFormat//(): string
}
class EternalGoal{
+ EternalGoal()

+ DisplayGoal(): string
+ RecordEvent(): void
+ IsCompleted(): void
+ GetSaveFormat(): void
}
class SimpleGoal{
- _completed: bool
+ SimpleGoal()

+ DisplayGoal(): string
+ RecordEvent(): void
+ IsCompleted(): void
+ GetSaveFormat(): void
}
class ChecklistGoal{
- _bonusPoints: int
- _bonusMark: int
- _numCompleted: int
+ ChecklistGoal()

+ DisplayGoal(): string
+ RecordEvent(): void
+ IsCompleted(): void
+ GetSaveFormat(): void
}
class User{
- _userPoints: int
- _listOfGoals: List<Goal>
+ User()
+ GetPoints(): int
+ SaveFile(string fileName): void
+ LoadFile(string fileName): void
+ AddNewGoal(Goal newGoal): void
+ RecordEvent(int indexOfGoal): void
+ ListGoals(): List<Goal>
}
@enduml
        */
    }
}