## Автоматизированная станция заправки

***

[Содержание](#содержание)

[Введение](#введение)

1 [Описание предметной области](#предметная_область)

1.1 [Проблематика](#проблематика)

1.2 [Цели и задачи](#цели_и_задачи)

2 [Сравнительный анализ](#сравнительный_анализ)

3 [Разработка системы](#разработка_системы)

3.1 [Этап проектирования](#проектирование)

3.2 [Этап реализации](#реализация)

4 [Тестирование](#тестирование)

[Заключение](#заключение)

[Список используемой литературы](#ссылки)

***

## Введение <a name="введение"></a>
***

 Современные технологии сделали возможным автоматизировать некоторые услуги, полностью или частично отказавшись от присутствия персонала, что позволяет бизнесу экономить немалые деньги, а также исключаются ошибки, связанные с человеческим фактором. Одной из таких услуг стала продажа бензина на специальных автоматизированных заправках. В последнее время такой тенденции стали следовать в сети АЗС "Газпром".

***
## 1 Описание предметной области <a name="предметная_область"></a>
***

Информационная система обеспечивает функционирование клиента, заправщика, и несколько заправочных станций. 

 Клиент - это человек, который будет получать услугу. Клиент может проссматривать актуальные акции и цены на топливо, оформлять заказ, писать отзывы как положительного, так и отрицательного характера.

 Администратор - управляет акциями, обновляет цены, регистрирует карты лояльности на клиентов. Он работает в удаленном доступе, что позволяет ему контролировать сразу несколько автоматизированных автозаправочных станций.
 
 Заправщик - работник станции, предназначенный для исправления ошибок работы автозаправки в реальном времени и после получения отзыва об ошибке. 
Оформление заказа. Заказ формируется в специальном хранилище, где указываются вид топлива, его количество, сумма заказа с учетом скидки по карте лояльности, данные о клиенте и его автомобиле. Далее происходит оплата заказа. Если оплата проходит успешно, заказ отправляется в хранилище заправки и ожидает начала выполнения. После окончания заправки, заказу присваивается статус "Успешно", который впоследствии остается в хранилище.

  В случае непрохождения оплаты возникает ошибка, которая приводит к сбою процесса заправки. 
 Ошибка может возникнуть в трех случаях:
 1) Отказ оплаты.
 2) Отсутствие топлива в баке АЗС.
 3) Другие технические неполадки.
 
  Все возможные ошибки, их номера и названия, пути решения определены в специальное хранилище. Сбой процесса реализации заправки предполагает его скорейшее восстановление заправщиком. При отсутствии топлива в топливных баках АЗС, отправляется специальный запрос на их пополнение.
  
  Отзыв. Данный пользовательский раздел предназначен для улучшения качества работы сервиса автоматизированных заправочных станций. Отзывы делятся на два вида.
  1) Положительный отзыв о работе АЗС.
  2) Отзыв, содержащий указание на ошибку в работе станции.
  
  Они хранятся в отдельном хранилище. После все отзывы проходят сортировку. Отзывы, в которых удалось выявить ошибки, помещаются в хранилище ошибок. Далее они исправляются заправщиком. Положительные отзывы отправляются администратору, для формирования данных об эффективной работе данной станции. 
  
  Система лояльности предполагает использование клиентами именных карт, для привлечения клиентов и их поощрения за пользование услугой заправки автомобиля. На одну карту может быть зарегистрирован один клиент, но он в свою очередь может иметь неограниченное количество автомобилей, что делает систему лояльности гибкой и малозатратной.

***
## 1.1 Проблематика <a name="проблематика"></a>
***

 В настоящее время существуют автозаправочные станции, которые отнимают много времени у водителей. Стандартная схема такова, что для оформления заказа клиент должен подождать, когда освободиться свободная колонка, после выйти из автомобиля и выстоять очередь в кассу для оплаты заказа, и наконец дождаться заправки автомобиля. На это уходит слишком много времени.
 Также на АЗС работает большое количество сотрудников, на которых ежемесячно уходит значительная часть прибыли.
 
***
## 1.2 Цели и задачи <a name="цели_и_задачи"></a>
***

 Цель данного проекта - упрощение получения услуги заправки автомобиля. Для осуществления данной цели предполагается выполнить следующие задачи.

1) Автоматизировать заправочные станции.
2) Ускорить процесс реализации заправки.
3) Упростить процесс оформления заказа.
4) Сократить число сотрудников АЗС.

***
## 2 Сравнительный анализ <a name="сравнительный_анализ"></a>
***

 Заправочные автоматические терминалы могут принимать наличные денежные средства, а также карты. При обустройстве станций можно выполнить либо считыватель для магнитных карт либо приемник для купюр. Очень часто для заправок выбирают оба устройства, чтобы обеспечить удобство оплаты для большего количества клиентов станции. В различных странах и городах соотношение оплаты купюрами и картой разниться.

 Автоматические АЗС чаще всего принимают от трех до 4 видов номиналов, выбираются самые распространенные. Новая информационная система позволяет использовать любой вид номинала, в том числе и монеты.
 
***

## 3 Разработка системы <a name="Описание_системы"></a>
***


  
*** 
## 3.1 Этап проектирования <a name="этап_проектирования"></a>
***



***
## 3.2 Этап реализации <a name="реализация"></a>
***



***
## 4 Тестирование <a name="тестирование"></a>
*** 



***
## Заключение <a name="заключение"></a>
***



***
## Используемая литература <a name="используемая_литература"></a>
***

[1] https://www.cleverence.ru/articles/elektronnaya-kommertsiya/sistema-r-keeper-chto-eto-takoe-printsip-raboty-programmy-luchshee-programmnoe-obespechenie-dlya-res/

***
