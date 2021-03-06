//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public partial class Entity {
        public TurnOrderComponent turnOrder { get { return (TurnOrderComponent)GetComponent(ComponentIds.TurnOrder); } }

        public bool hasTurnOrder { get { return HasComponent(ComponentIds.TurnOrder); } }

        public Entity AddTurnOrder(System.Collections.Generic.LinkedList<Entitas.Entity> newValue) {
            var component = CreateComponent<TurnOrderComponent>(ComponentIds.TurnOrder);
            component.value = newValue;
            return AddComponent(ComponentIds.TurnOrder, component);
        }

        public Entity ReplaceTurnOrder(System.Collections.Generic.LinkedList<Entitas.Entity> newValue) {
            var component = CreateComponent<TurnOrderComponent>(ComponentIds.TurnOrder);
            component.value = newValue;
            ReplaceComponent(ComponentIds.TurnOrder, component);
            return this;
        }

        public Entity RemoveTurnOrder() {
            return RemoveComponent(ComponentIds.TurnOrder);
        }
    }

    public partial class Pool {
        public Entity turnOrderEntity { get { return GetGroup(Matcher.TurnOrder).GetSingleEntity(); } }

        public TurnOrderComponent turnOrder { get { return turnOrderEntity.turnOrder; } }

        public bool hasTurnOrder { get { return turnOrderEntity != null; } }

        public Entity SetTurnOrder(System.Collections.Generic.LinkedList<Entitas.Entity> newValue) {
            if (hasTurnOrder) {
                throw new EntitasException("Could not set turnOrder!\n" + this + " already has an entity with TurnOrderComponent!",
                    "You should check if the pool already has a turnOrderEntity before setting it or use pool.ReplaceTurnOrder().");
            }
            var entity = CreateEntity();
            entity.AddTurnOrder(newValue);
            return entity;
        }

        public Entity ReplaceTurnOrder(System.Collections.Generic.LinkedList<Entitas.Entity> newValue) {
            var entity = turnOrderEntity;
            if (entity == null) {
                entity = SetTurnOrder(newValue);
            } else {
                entity.ReplaceTurnOrder(newValue);
            }

            return entity;
        }

        public void RemoveTurnOrder() {
            DestroyEntity(turnOrderEntity);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherTurnOrder;

        public static IMatcher TurnOrder {
            get {
                if (_matcherTurnOrder == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.TurnOrder);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherTurnOrder = matcher;
                }

                return _matcherTurnOrder;
            }
        }
    }
}
