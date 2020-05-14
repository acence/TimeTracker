/// <binding BeforeBuild='build:css-sass' AfterBuild='lint:js' />
var gulp = require('gulp');
var sass = require('gulp-sass');
var rename = require('gulp-rename');
var eslint = require('gulp-eslint');

gulp.task('build:css-sass', () => {
    return gulp.src(['./Styles/*.scss'])
        .pipe(sass().on('error', sass.logError))
        .pipe(rename((path) => {
            path.basename = path.basename.toLowerCase();
        }))
        .pipe(gulp.dest('./wwwroot/css'));
});

gulp.task('lint:js', () => {
    return gulp.src(['Scripts/**/*.jsx'])
        .pipe(eslint())
        .pipe(eslint.format())
        .pipe(eslint.failAfterError());
});