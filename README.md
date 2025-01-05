# DoorScript
Скрипт двери для Unity 3D

# КАК ИСПОЛЬЗОВАТЬ?
1. Создайте объект, который будет выступать за роль двери
2. Добавьте ему этот скрипт
3. Добавьте анимации открытия и закрытия
# КАК НАСТРОИТЬ АНИМАТОР?
1. Добавьте анимации открытия и закрытия
2. Создайте пустую анимацию (ПКМ -> Create state -> Empty)
3. Назовите её Wait
4. Сделайте её основной 
5. Добавьте параметр Bool "isOpen"
6. Добавьте переход от Wait к анимации открытия двери
7. В Conditions приравняйте состоянию "isOpen" True
8. Прировняйте полю "Has exit time" False
9. Добавьте переход от анимации открытия к анимации закрытия двери
10. Настройте их также как в пункте 7
