document.addEventListener('DOMContentLoaded', function () {
    var elems = document.querySelectorAll('.datepicker_my');

    var instances = M.Datepicker.init(elems, {
        i18n: {
            months: ['Січень', 'Лютий', 'Березень', 'Квітень', 'Травень', 'Червень', 'Липень', 'Серпень',
                'Вересень', 'Жовтень', 'Листопад', 'Грудень'],
            monthsShort: ['Січ', 'Лют', 'Бер', 'Кві', 'Тра', 'Чер', 'Лип', 'Сер', 'Вер', 'Жов', 'Лис', 'Гру'],
            weekDays: ['Неділя', 'Понеділок', 'Вівторок', 'Середа', 'Четвер', 'Пятниця', 'Субота'],
            weekdaysShort: ['Нед', 'Пон', 'Вів', 'Сер', 'Чет', 'Пят', 'Суб'],
            weekdaysAbbrev: ['Нд', 'Пд', 'Вт', 'Ср', 'Чт', 'Пн', 'Сб'],
            cancel: 'Відміна',
            clear: 'Очистити',
            done: 'Ок'
        },
        showClearBtn: true
    });

    var elemstime = document.querySelectorAll('.timepicker_my');
    var instancestime = M.Timepicker.init(elemstime, {
        i18n: {
            cancel: 'Відміна',
            clear: 'Очистити',
            done: 'Ок'
        },
        twelveHour: false,
        showClearBtn: true
    });

    
});
