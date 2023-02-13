# GuessTheLetter
## ScripteableObject (Черновой вариант)
### Компонента хрянящая:
* Границицы чисел ASCII,представлены константными значениями для букв, цифр, знаков.

| Начало | Конец |
|--------|-------|
| 48     | 58    |
| 65     | 91     |
| 1      | 32     |
* Элемент перечисления **_setName** выбранного режима игры.
```
public enum SetName
    {
        Signs = 0,
        Words = 1,
        Numbers = 2
    }
```
* Ссылка на создаваемый префаб.
```
[SerializeField] 
private GameObject _letterPrefab;
```
* Иконка выбранного набора **_letterIcon**.
* Словарь <Символ,иконка> **_playableLetters**.
```
public void Initialize(SetName name) - функция инициализации набора, с учётом выбранного символа
private void RandomizeSymbols() - Создание иконок, с рандомными символами и их запись в словарь
private void GetBorders(out int minValue, out int maxValue) - Получение значений границ, в соответствии с таблицей ASCII
```