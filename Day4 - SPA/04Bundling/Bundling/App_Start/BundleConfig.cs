using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Bundling {
    public class BundleConfig {

        public static void RegisterBundles(BundleCollection bundles) {

            bundles.Add(new ScriptBundle("~/MyScripts").Include(
                "~/App_Scripts/B.js",
                "~/App_Scripts/A.js",
                "~/Scripts/jQuery-{version}.js"
            ));


            // control ordering
            //bundles.FileSetOrderList.Clear();


        }

    }
}