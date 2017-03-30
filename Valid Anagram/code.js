/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 */
var isAnagram = function(s, t) {
    var count = s.length;
    if (count != t.length)
        return false;

    var arrS = [], arrT = [];
    for (var i = 0; i < count; i++) {
        arrS[s[i]] = arrS[s[i]] ? ++arrS[s[i]] : 1;
        arrT[t[i]] = arrT[t[i]] ? ++arrT[t[i]] : 1;
    }
    
    for (i = 0; i < count; i++) {
        if (arrS[s[i]] != arrT[s[i]])
            return false;
    }

    return true;
};