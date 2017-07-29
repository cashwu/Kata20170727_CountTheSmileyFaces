# [Count the smiley faces!](https://www.codewars.com/kata/583203e6eb35d7980400002a)

---

Given an array (arr) as an argument complete the function `countSmileys` that should return the total number of smiling faces.

Rules for a smiling face:
- Each smiley face must contain a valid pair of eyes. Eyes can be marked as `:` or `;`
- A smiley face can have a nose but it does not have to. Valid characters for a nose are `-` or `~`
- Every smiling face must have a smiling mouth that should be marked with either `)` or `D`.
No additional characters are allowed except for those mentioned.

Valid smiley face examples:

`:) :D ;-D :~)`

Invalid smiley faces:

`;( :> :} :]` 

Example cases:
```
countSmileys([':)', ';(', ';}', ':-D']);       // should return 2;
countSmileys([';D', ':-(', ':-)', ';~)']);     // should return 3;
countSmileys([';]', ':[', ';*', ':$', ';-D']); // should return 1;
```
Note: In case of an empty array return 0. You will not be tested with invalid input (input will always be an array)

---

### 中文大意

計算符號裡面有幾個笑臉，一定要有眼睛和嘴巴，鼻子不一定要有，不可以使用沒有規定的符號
