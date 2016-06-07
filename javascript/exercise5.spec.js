(function(){
    'use strict';
    
    describe('startsWith Tests: ', () => {
        
        var truthySubjects = ["hang", "", "hang the", "han", "hang t"];
        var falsySubjects = ["Hang", "I’ve got a room for rent", "42", "{ first: “Johnny” }"];

        var theString = "hang the dj";
        
        for (var i = 0; i < truthySubjects.length; i++) {
            (function (testString) {
                it('The string "'+ theString +'" starts with "' + testString +'"', function () {
                    expect(theString.startsWith(testString)).toBeTruthy();
                });
            })(truthySubjects[i]);
        };

        for (var i = 0; i < falsySubjects.length; i++) {
            (function (testString) {
                it('The string "'+ theString +'" does not start with "' + testString +'"', function () {
                    expect(theString.startsWith(testString)).toBeFalsy();
                });
            })(falsySubjects[i]);
        };            
    });

    describe('endsWith Tests: ', () => {
        
        var truthySubjects = ["dj", "", "the dj", "e dj", "j"];
        var falsySubjects = ["panic on the streets", "42", "{ first: “Johnny” }"];

        var theString = "hang the dj";
        
        for (var i = 0; i < truthySubjects.length; i++) {
            (function (testString) {
                it('The string "'+ theString +'" ends with "' + testString +'"', function () {
                    expect(theString.endsWith(testString)).toBeTruthy();
                });
            })(truthySubjects[i]);
        };

        for (var i = 0; i < falsySubjects.length; i++) {
            (function (testString) {
                it('The string "'+ theString +'" does not end with "' + testString +'"', function () {
                    expect(theString.endsWith(testString)).toBeFalsy();
                });
            })(falsySubjects[i]);
        };            
    });
        

})();
