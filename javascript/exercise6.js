(function(prototype){
    'use strict';
    /* this will override even ES6 implementation */
    prototype.stripHtml = function(){       
        return this.toString().replace(/<\/?[^>]+(>|$)/g, "");        
    };
    
})(String.prototype);