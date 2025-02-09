## Unity Event Bus System

This repository contains a simple and flexible Event Bus system developed for use in Unity projects. This system allows different game components to react to events without knowing about each other, making your code modular, flexible, and scalable.

## Features

Generic Event System: Works with any type of event, so you can use a single event bus for different types of events.
Dynamic Listeners: You can add and remove listeners dynamically. Listeners can be added and removed at runtime.
Decoupled Systems: Systems can react to events without knowing about each other, reducing dependencies and improving modularity.
Efficient Communication: Delegates and generics are used to provide efficient and fast communication.

## Usage

1. **Define an Event Class**
   
- First, you need to create classes that represent the events you want to listen to. These classes should implement the IEvent interface.

![image](https://github.com/user-attachments/assets/c0aa0f39-6ed2-4692-b90c-76b643599fd9)

2. **Create a Listener**
   
- Now, create a listener class that will respond to events. The listener class will contain methods for handling specific event types.

![image](https://github.com/user-attachments/assets/f5f9e4a6-8083-44d6-a133-f49d430f471a)

3. **Subscribe the Listener to the Event Bus**
   
- To subscribe a listener to the event bus, create an EventListener<T> object and register it using the EventBus<T>.AddListener method.

![image](https://github.com/user-attachments/assets/07a28dcb-8ba1-46b8-a128-e0a82d4bf195)

4. **Trigger the Event**
   
- To trigger an event, simply call the EventBus<T>.Emit method, which will notify all subscribed listeners.

![image](https://github.com/user-attachments/assets/b9fe9f3a-dabc-43dc-b238-b8d710f0d4d9)

## Event Bus Structure

- EventListener<T>: This class holds the listener's methods to respond to events. Listeners can be added or removed at runtime via delegates.

- EventBus<T>: This class is responsible for triggering events. The event bus holds all listeners and invokes their methods when an event is triggered. It also provides functionality to add and remove listeners.



