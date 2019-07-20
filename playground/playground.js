
(() => {

  let testArrow = {

    data: "address",

    methodOld: function() {
      console.log(`old ${this.data}`);
    },

    methodNew: () => {
      return () => {

        console.log(`new ${testArrow.data}`);
      };
    }
  };


  testArrow.methodOld();
  testArrow.methodNew()();

})();
