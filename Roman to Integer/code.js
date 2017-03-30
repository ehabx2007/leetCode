/**
 * @param {string} s
 * @return {number}
 */
var romanToInt = function(s) {
    var count = s.length;
    var values = [];
    values['I'] = 1;
    values['V'] = 5;
    values['X'] = 10;
    values['L'] = 50;
    values['C'] = 100;
    values['D'] = 500;
    values['M'] = 1000;
    var sum = 0;
    
        for (var i = count - 1; i >= 0; i--) {

            if (i == 0) {
                sum += values[s[i]];
            }
            else if (values[s[i]] > values[s[i - 1]]) {
                sum += (values[s[i]] - values[s[i - 1]]);
                i -= 1;
            }
            else{
                sum += values[s[i]];
            }

        }

        return sum;
};