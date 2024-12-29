// dichiaro una coda di interi
var queue = new Queue<int>(new[] { 1, 2, 3, 4 });

// elimino il primo elemento
queue.Dequeue();

// stampo la coda aggiornata
Console.WriteLine("Queue aggiornata:");
foreach (int item in queue)
{
    Console.WriteLine(item);
}
