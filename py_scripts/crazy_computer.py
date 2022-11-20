# Crazy Computer v1.0
# Author: Alexandr -Nexurion- Drochnev.
# Create date: 2022.11.20
# This is a simple script to protect your computer from children.

import os
import time

print("Приветстаую!", "\n", "Хочешь воспользоваться мною?")
answer = input("Нажмите Y/N: ")
if (answer == "y"):
    print("Что-ж, тогда ответь ка мне на парочку вопросов.")
else:
    print("Эмм... тогда зачем ты его включил? О_О")
    print("Выключаю ПК!")
    time.sleep(1)
    os.system("shutdown /r /t 0")

#  Проверка возраста пользователя.
print("Сколько тебе лет?")
age = int(input("Введите ваш возраст: "))
age = 18
if (age >= 18):
    print("Окей, проверку на возраст прошел. Поехали дальше.")
    time.sleep(1)
else:
    print("Прости, ты слишком маленький, чтобы сидеть за компом. Выключаю ПК!")
    time.sleep(1)
    os.system("shutdown /r /t 0")

#  Загадка.
print("Если сможешь отгадать одну загадку, я отстану. Попробуешь?")
answer_2 = input("Y/N: ")
if (answer_2 == "y"):
    print("Смельчак, да?", "\n", "Хорошо, тогда слушай.")
    time.sleep(2)
    print("")
    print("=======================")
    print("Страну чудес откроем мы")
    print("И встретимся с героями")
    print("В строчках,")
    print("На листочках,")
    print("Где станции на точках.")
    print("=======================")
    print("")

    answ_zagadka = input("Ответ: ")
    if (answ_zagadka == "книга"):
        time.sleep(2)
        print("Молодец!")
        time.sleep(2)
        print("Ты прошел проверку.")
        time.sleep(2)
        print("Можешь пользоваться компьютером. ;)")
else:
    print("Мда, струсил? боишься показать всем, что ты тупой?")
    time.sleep(2)
    print("В таком случае, тебе пора уроки делать!")
    time.sleep(2)
    print("Выключение компьютера через: ")
    time.sleep(1)
    print("3..."), time.sleep(1), print("2..."), time.sleep(1), print("1..."), time.sleep(1)
#    print("BOO!!!")
    os.system("shutdown /r /t 0")
