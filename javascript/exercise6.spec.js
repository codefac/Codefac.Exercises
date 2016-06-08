(function(){
    'use strict';
    
    describe('stripHtml Tests: ', function(){
                        /* { rawString: sanitizedString} */
        var subjects = [
                        {"<p>Shoplifters of the World <em>Unite</em>!</p>": "Shoplifters of the World Unite!"},
                        {"1 &lt; 2": "1 &lt; 2"}
                       ];
               
        for (var i = 0; i < subjects.length; i++) {
            for (var rawstring in subjects[i]) {
                (function (rawstring, sanitizedString) {
                    it('Raw string"'+ rawstring +'" results in "' + sanitizedString +'"', function () {
                        expect(rawstring.stripHtml()).toBe(sanitizedString);
                    });
                })(rawstring, subjects[i][rawstring]);
            };
        };        
    });
        

})();
