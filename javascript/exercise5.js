(function(prototype){
    'use strict';
    /* this will override even ES6 implementation */
    prototype.startsWith = function(searchString){  
        return this.substr(0, searchString.length) === searchString;
    };

    prototype.endsWith = function(searchString){  
        var subjectString = this.toString();
        var position = subjectString.length;
        
        position -= searchString.length;
        var lastIndex = subjectString.indexOf(searchString, position);
        return lastIndex !== -1 && lastIndex === position;
    };
    
    
})(String.prototype);